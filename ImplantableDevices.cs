using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hl7.Fhir.Model;
namespace PatientDevices
{
  public partial class FormPatientDevices : Form
  {
    public FormPatientDevices()
    {
      InitializeComponent();
    }

    private void BtnSearchPatient_Click(object sender, EventArgs e)
    {
      //When the button is pressed, we search the patient
      SearchPatients();
    }

    private void WorkingMessage()
    {
      lblErrorMessage.Text = "Working...";
      this.UseWaitCursor = true;
    }

    private void SearchDevices(string PatientId)
    {
      WorkingMessage();
      //Empty the device list
      listDevices.Items.Clear();
      //My FHIR Endpoint
      string FHIR_EndPoint = this.txtFHIREndpoint.Text.ToString();
      //Connection
      var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint);

      try
      {
        //Find the device related to my patient
        var p = new Hl7.Fhir.Rest.SearchParams();
        p.Add("patient", PatientId);

        var results = client.Search<Device>(p);
        this.UseWaitCursor = false;
        lblErrorMessage.Text = "";
        while (results != null)
        {
          if (results.Total == 0) lblErrorMessage.Text = "No devices found";
          //Traverse the bundle with results
          foreach (var entry in results.Entry)
          {
            //One Device found!
            var Device = (Device)entry.Resource;
            string Content = "";
            //Fill the content to add to the list with all the device data
            //Just in case the UDICarrier info is not present, we show just Manufacturer and Identifier
            if (Device.UdiCarrier.Count > 0)
            {
              Content = Device.UdiCarrier[0].CarrierHRF
                       + " - " + Device.UdiCarrier[0].DeviceIdentifier
                       + " - " + Device.Manufacturer;
            }
            else
            {
              if (Device.Identifier.Count > 0)
              {
                Content = Device.Identifier[0].System + "-" + Device.Identifier[0].Value + " -" + Device.Manufacturer;
              }
              else
              {
                Content = Device.Manufacturer + " ( No Identifiers )";
              }

            }
            Content += $"-{Device.DistinctIdentifier}-{Device.Type.Coding[0].Code}-{Device.ManufactureDate}-{Device.ExpirationDate}-{Device.LotNumber}-{Device.SerialNumber}";
            listDevices.Items.Add(Content);


          }
          // get the next page of results
          results = client.Continue(results);
        }
      }
      catch (Exception err)
      {
        lblErrorMessage.Text = "Error:" + err.Message.ToString();

      }
      if (lblErrorMessage.Text != "") { lblErrorMessage.Visible = true; }

    }
    private void SearchPatients()
    {
      //Regular search by patient family and given name
      WorkingMessage();
      listCandidates.Items.Clear();
      string FHIR_EndPoint = this.txtFHIREndpoint.Text.ToString();
      var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint);

      try
      {
        string family = txtFamilyName.Text.ToString();
        string given = txtGivenName.Text.ToString();
        var p = new Hl7.Fhir.Rest.SearchParams();
        p.Add("family", family);
        if (given != "")
        { p.Add("given", given); }
        var results = client.Search<Patient>(p);
        this.UseWaitCursor = false;
        lblErrorMessage.Text = "";

        while (results != null)
        {
          if (results.Total == 0) lblErrorMessage.Text = "No patients found";
          btnShowDevices.Enabled = true;
          foreach (var entry in results.Entry)
          {

            var Pat = (Patient)entry.Resource;
            string Fam = Pat.Name[0].Family;
            string Giv = Pat.Name[0].GivenElement[0].ToString();
            string ideS = Pat.Identifier[0].System;
            string ideV = Pat.Identifier[0].Value;
            string Content = Fam + " " + Giv + " (" + ideS + "-" + ideV + ")";
            ListViewItem l = new ListViewItem();
            l.Text = Content;
            l.Tag = entry.Resource.Id;
            listCandidates.Items.Add(l);

          }

          // get the next page of results
          results = client.Continue(results);
        }
      }
      catch (Exception err)
      {
        lblErrorMessage.Text = "Error:" + err.Message.ToString();
      }
      if (lblErrorMessage.Text != "") { lblErrorMessage.Visible = true; }

    }

    private void BtnShowDevices_Click(object sender, EventArgs e)
    {
      ListViewItem l = (listCandidates.SelectedItem as ListViewItem);
      string patientId = l.Tag.ToString();
      SearchDevices(patientId);
    }
  }
}
