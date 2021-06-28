using System;
using BUS;

namespace GUI
{
    public partial class FormCreateImportedMedicineSlip : MyForm
    {
        public FormCreateImportedMedicineSlip(FormMain parent)
        {
            InitializeComponent();
            this.parent = parent;
            AddEventHandler();

            //this.tbName.Text = "1";
            //this.cbUnit.Text = "1";
            //this.tbQuantityOfInput.Text = "20";
            //this.tbImportedUnitPrice.Text = "5000";
            //this.tbRationToCalculateSellableUnitPrice.Text = "100";

            this.bAddUnit.Click += (s, e) =>
            {
                FormAddMedicalUnit formAddMedicalUnit = new FormAddMedicalUnit();
                BUS.EventHandler.ShowFormDialog(formAddMedicalUnit);
            };
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
            this.bReset.Click += Reset;
        }

        private void Reset(object sender, EventArgs e)
        {
            this.cbName.Text = this.cbUnit.Text = this.tbQuantityOfInput.Text =
                this.tbImportedUnitPrice.Text = this.tbSellableUnitPrice.Text =
                this.tbRationToCalculateSellableUnitPrice.Text = "";
        }

        private async void LoadUnit(object sender, EventArgs e)
        {
            this.cbUnit = await CreateImportedMedicineSlipHandler.LoadUnit(this.cbUnit);
        }

        private void CheckUnit(object sender, EventArgs e)
        {
            CreateImportedMedicineSlipHandler.CheckUnit(this.cbUnit);
        }

        private void CheckRation(object sender, EventArgs e)
        {
            CreateImportedMedicineSlipHandler.CheckInput(sender, "Tỷ lệ tính đơn giá bán", 99);
        }

        private void CheckPrice(object sender, EventArgs e)
        {
            CreateImportedMedicineSlipHandler.CheckInput(sender, "Đơn giá nhập");
        }

        private void CheckInput(object sender, EventArgs e)
        {
            CreateImportedMedicineSlipHandler.CheckInput(sender, "Số lượng nhập");
        }

        private async void AddMedicine(object sender, EventArgs e)
        {
            if (!CreateImportedMedicineSlipHandler.IsError(this.tbQuantityOfInput, this.tbImportedUnitPrice,
                this.tbRationToCalculateSellableUnitPrice, this.cbUnit))
            {
                this.dgvMedicineList =
                    await CreateImportedMedicineSlipHandler.CreateDetailImportedMedicineSlip(this.cbName.Text,
                    int.Parse(this.tbImportedUnitPrice.Text), this.cbUnit.Text,
                    int.Parse(this.tbRationToCalculateSellableUnitPrice.Text),
                    int.Parse(this.tbQuantityOfInput.Text), this.dgvMedicineList);
            }
        }

        private void FormCreateImportedMedicineSlip_Load(object sender, EventArgs e)
        {

        }
    }
}