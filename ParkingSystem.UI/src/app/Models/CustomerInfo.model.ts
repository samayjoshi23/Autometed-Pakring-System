export interface CustomerVehicle{
    vehicle_Id : string;
    customerId : number;
    owner_Name : string;
    vehicle_Number :string;
    floorId : number;
    slotId : number;
    parkingTime : string | null;
    unparkingTime : string | null;
    parkingPin : number | null;
}