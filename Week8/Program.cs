using Week8;

Letter letter1 = new Letter("123", 5.5);
Letter letter2 = new Letter("456", 4.3);
Parcel parcel1 = new Parcel("30x20x10", "345", 2.3);
Parcel parcel2 = new Parcel("30x60x10", "789", 3.3);

letter1.PrintInfo();
parcel2.PrintInfo();

CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();

myCargo.AddItem(parcel1);
myCargo.AddItem(parcel2);
myCargo.AddItem(letter1);
myCargo.AddItem(letter2);

Console.WriteLine($"Total sum is: {myCargo.GetTotalCost()}");