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

            this.cbMedicineName.Text = "Paracetamol";
            this.cbUnit.Text = "Viên";
            this.tbQuantityOfInput.Text = "10";
            this.tbImportedUnitPrice.Text = "5000";
            this.tbRatioToCalculateSellableUnitPrice.Text = "100";
        }

        protected override void AddEventHandler()
        {
            base.AddEventHandler();
            this.bAdd.Click += AddMedicine;
            this.bAddUnit.Click += AddUnit;
            this.cbUnit.KeyPress += LockInputNumber;
            this.tbQuantityOfInput.KeyPress += LockInputWord;
            this.tbImportedUnitPrice.KeyPress += LockInputWord;
            this.tbRatioToCalculateSellableUnitPrice.KeyPress += LockInputWord;
            this.tbQuantityOfInput.Leave += CheckInput;
            this.tbImportedUnitPrice.Leave += CheckPrice;
            this.tbRatioToCalculateSellableUnitPrice.Leave += CheckRation;
            this.cbUnit.Leave += CheckUnit;
            this.Load += LoadComboBox;
            this.Load += LoadMedicineList;
            this.bReset.Click += Reset;
            this.bCancel.Click += CloseForm;
            this.tbImportedUnitPrice.Leave += ShowSellableUnitPrice;
            this.tbRatioToCalculateSellableUnitPrice.Leave += ShowSellableUnitPrice;
        }

        private async void LoadMedicineList(object sender, EventArgs e)
        {
            this.dgvMedicineList = 
                await CreateImportedMedicineSlipHandler.LoadMedicineList(this.dgvMedicineList);
        }

        private void AddUnit(object sender, EventArgs e)
        {
            BUS.EventHandler.ShowFormDialog(new FormAddMedicalUnit());
            LoadComboBox(sender, e);
        }

        private void ShowSellableUnitPrice(object sender, EventArgs e)
        {
            CreateImportedMedicineSlipHandler.ShowSellableUnitPrice(this.tbImportedUnitPrice,
                this.tbRatioToCalculateSellableUnitPrice, ref this.tbSellableUnitPrice);
        }

        private void Reset(object sender, EventArgs e)
        {
            this.cbMedicineName.Text = this.cbUnit.Text = this.tbQuantityOfInput.Text =
                this.tbImportedUnitPrice.Text = this.tbSellableUnitPrice.Text =
                this.tbRatioToCalculateSellableUnitPrice.Text = "";
        }

        private async void LoadComboBox(object sender, EventArgs e)
        {
            this.cbUnit = await CreateImportedMedicineSlipHandler.LoadUnit(this.cbUnit);
            this.cbMedicineName = 
                await CreateImportedMedicineSlipHandler.LoadMedicineName(this.cbMedicineName);
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
                this.tbRatioToCalculateSellableUnitPrice, this.cbUnit))
            {
                this.dgvImportedMedicineList =
                    await CreateImportedMedicineSlipHandler.CreateDetailImportedMedicineSlip(this.cbMedicineName.Text,
                    int.Parse(this.tbImportedUnitPrice.Text), this.cbUnit.Text,
                    int.Parse(this.tbRatioToCalculateSellableUnitPrice.Text),
                    int.Parse(this.tbQuantityOfInput.Text), this.dgvImportedMedicineList);
                LoadMedicineList(sender, e);
            }
        }
    }
}