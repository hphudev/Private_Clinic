using System;
using BUS;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class FormImportMedicine : MyForm
    {
        public FormImportMedicine(FormMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            AddEventHandler();

            this.tbName.Text = "1";
            this.cbUnit.Text = "1";
            this.tbQuantityOfInput.Text = "20";
            this.tbImportedUnitPrice.Text = "5000";
            this.tbRationToCalculateSellableUnitPrice.Text = "100";

            //this.bAddUnit.Click += (s, e) =>
            //{
            //    FormAddMedicalUnit formAddMedicalUnit = new FormAddMedicalUnit();
            //    BUS.EventHandler.ShowFormDialog(formAddMedicalUnit);
            //};
            //this.bEditMedical.Click += (s, e) =>
            //{
            //    FormEditMedical formEditMedical = new FormEditMedical();
            //    BUS.EventHandler.ShowFormDialog(formEditMedical);
            //};
        }

        protected override void AddEventHandler()
        {
            base.AddEventHandler();
            this.bAdd.Click += AddMedicine;
            this.cbUnit.KeyPress += LockInputNumber;
            this.tbQuantityOfInput.KeyPress += LockInputWord;
            this.tbImportedUnitPrice.KeyPress += LockInputWord;
            this.tbRationToCalculateSellableUnitPrice.KeyPress += LockInputWord;
            this.tbQuantityOfInput.Leave += CheckInput;
            this.tbImportedUnitPrice.Leave += CheckPrice;
            this.tbRationToCalculateSellableUnitPrice.Leave += CheckRation;
            this.cbUnit.Leave += CheckUnit;
            this.Load += LoadUnit;
        }

        private async void LoadUnit(object sender, EventArgs e)
        {
            this.cbUnit = await ImportedMedicineHandler.LoadUnit(this.cbUnit);
        }

        private void CheckUnit(object sender, EventArgs e)
        {
            ImportedMedicineHandler.CheckUnit(this.cbUnit);
        }

        private void CheckRation(object sender, EventArgs e)
        {
            ImportedMedicineHandler.CheckInput(sender, "Tỷ lệ tính đơn giá bán", 99);
        }

        private void CheckPrice(object sender, EventArgs e)
        {
            ImportedMedicineHandler.CheckInput(sender, "Đơn giá nhập");
        }

        private void CheckInput(object sender, EventArgs e)
        {
            ImportedMedicineHandler.CheckInput(sender, "Số lượng nhập");
        }

        private async void AddMedicine(object sender, EventArgs e)
        {
            if (!ImportedMedicineHandler.IsError(this.tbQuantityOfInput, this.tbImportedUnitPrice,
                this.tbRationToCalculateSellableUnitPrice, this.cbUnit))
            {
                this.dgvMedicineList =
                    await ImportedMedicineHandler.CreateDetailImportedMedicineSlip(this.tbName.Text,
                    int.Parse(this.tbImportedUnitPrice.Text), this.cbUnit.Text,
                    int.Parse(this.tbRationToCalculateSellableUnitPrice.Text),
                    int.Parse(this.tbQuantityOfInput.Text), this.dgvMedicineList);
            }
        }
    }
}