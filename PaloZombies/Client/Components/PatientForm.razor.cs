using PaloZombies.Shared.DTOs;
using PaloZombies.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Client.Components
{
    //uses a State variable to track the state of the form.
    // this form is completed in steps
    public partial class PatientForm
    {
        private Patient _patient;
        private int FormState;
        private bool loading;
        protected override Task OnInitializedAsync()
        {
            _patient = new Patient();
            return base.OnInitializedAsync();
        }

        private void SetSelectedIllness(Illness illness)
        {
            _patient.Illness = illness;
            FormState++;
        }

        private void SetSelectedLevelOfPain(int painLevel)
        {
            _patient.LevelOfPain = painLevel;
            //if the user comes back to the back after selecting..and changes level of pain
            //new list will be rendered so reset hospital
            _patient.SelectedHospital = null;
            FormState++;
        }
        private void SetSelectedHospital(HospitalDTO hospitalDTO)
        {
            _patient.SelectedHospital = hospitalDTO;
            FormState++;
        }
        private void SetPreviousState()
        {
            if (FormState != 0)
                FormState--;
        }
        
        private async Task SubmitForm()
        {
            loading = true;
            var returnedPatientWithId=await _patientService.SavePatient(_patient);
            if(returnedPatientWithId==null)
            {
                FormState++;
            }
            else
            {
                _patient = returnedPatientWithId;
                FormState++;
            }
            loading = false;
        }
    }
}
