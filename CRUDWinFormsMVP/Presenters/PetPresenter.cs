using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDWinFormsMVP.Models;
using CRUDWinFormsMVP.Views;

namespace CRUDWinFormsMVP.Presenters
{
    public class PetPresenter
    {
        //Fields
        private IPetView view;
        private IPetRepository repository;
        private BindingSource petsBindingSource;
        private IEnumerable<PetModel> petList;

        //Constructor
        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.petsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //Suscribimos los metodos de eventos del controlador
            //a los eventos de vistas(Implementamos lo que se va hacer
            //cuando un evento se ejecute)
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;
            //Establecemos la fuente vinculante de la lista de mascotas
            //mediante el metodo definido e implementado en la vista
            this.view.SetPetListBindingSource(petsBindingSource);
            LoadAllPetList();
            this.view.Show();
        }

        private void LoadAllPetList()
        {
            petList = repository.GetAll();
            petsBindingSource.DataSource = petList;
        }
        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                petList = repository.GetByValue(this.view.SearchValue);
            else petList = repository.GetAll();
            petsBindingSource.DataSource= petList;

        }
        private void AddNewPet(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            var pet = (PetModel)petsBindingSource.Current;
            view.PetId = pet.Id.ToString();
            view.PetName = pet.Name;
            view.PetType = pet.Type;
            view.PetColour = pet.Colour;
            view.IsEdit = true;
        }
        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            try 
            {
                //Modelo mascota actualmente seleccionado en
                //la lista de la fuente vinculante DataGridView
                var pet = (PetModel)petsBindingSource.Current;
                repository.Delete(pet.Id);
                view.IsSuccessful = true;
                view.Message = "Mascota Eliminada correctamente ❌";
                LoadAllPetList();

            }
            catch(Exception)
            {
                view.IsSuccessful = false;
                view.Message = "Algo esta ocurriendo, no se puedo Eliminar ⚠️";
            }
        }
        private void SavePet(object sender, EventArgs e)
        {
            var model = new PetModel();
            model.Id = Convert.ToInt32(view.PetId);
            model.Name = view.PetName;
            model.Type = view.PetType;
            model.Colour = view.PetColour;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if(view.IsEdit)
                {
                    repository.Edit(model);
                    view.Message = "Mascota Editada satisfactoriamente 🔧✅ ";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Nueva mascota Agregada satisfactoriamente ➕✅";
                }
                view.IsSuccessful = true;
                LoadAllPetList();
                cleanViewFields();
            }
            catch (Exception ex)
            { 
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void cleanViewFields()
        {
            view.PetId = "0";
            view.PetName = "";
            view.PetType = "";
            view.PetColour = "";
        }

        private void CancelAction(object sender, EventArgs e)
        {
            cleanViewFields();
        }
    }

}
