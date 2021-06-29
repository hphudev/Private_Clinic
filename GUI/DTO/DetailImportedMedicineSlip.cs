using System;

namespace DTO
{
    public class DetailImportedMedicineSlip : IdentifiableObject
    {
        private string medicineID;
        private int currentSellableUnitPrice, currentRatioToCalculateSellableUnitPrice;
        DateTime importedMedicineDate;

        public int quantityOfInput { get; }

        public override string GetValueForInsertIntoSQL()
        {
            string[] tmps = new string[2];
            tmps[0] = "'";
            tmps[1] = "', '";

            return tmps[0] + this.ID + tmps[1] + this.medicineID + tmps[1] + this.quantityOfInput +
                tmps[1] + this.importedMedicineDate.Day + "/" + this.importedMedicineDate.Month + "/" +
                this.importedMedicineDate.Year + tmps[1] + this.currentSellableUnitPrice + tmps[1] +
                this.currentRatioToCalculateSellableUnitPrice + tmps[0];
        }

        public DetailImportedMedicineSlip(string ID, string medicineID, int quantityOfInput,
            DateTime importedMedicineDate, int currentSellableUnitPrice,
            int currentRatioToCalculateSellableUnitPrice) : base(ID)
        {
            this.medicineID = medicineID;
            this.quantityOfInput = quantityOfInput;
            this.importedMedicineDate = importedMedicineDate;
            this.currentSellableUnitPrice = currentSellableUnitPrice;
            this.currentRatioToCalculateSellableUnitPrice = currentRatioToCalculateSellableUnitPrice;
        }
    }
}