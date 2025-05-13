using System;

public class Patient
{
    public int PatientID { get; set; }
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Condition { get; set; }

    // Calculates and returns the patient's age
    public int GetAge()
    {
        int age = DateTime.Now.Year - DateOfBirth.Year;
        if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            age--; // Adjust for incomplete year
        return age;
    }

    // Displays patient's information
    public void DisplayPatientDetails()
    {
        Console.WriteLine($"Patient ID: {PatientID}");
        Console.WriteLine($"Name: {FullName}");
        Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Condition: {Condition}");
        Console.WriteLine($"Age: {GetAge()}");
    }
}



public class MonitoringDevice
{
    public int DeviceID { get; set; }
    public string DeviceName { get; set; }
    public string Model { get; set; }
    public int AssignedPatientID { get; set; }

    // Checks if the device is currently assigned to a patient
    public bool IsAssigned()
    {
        return AssignedPatientID > 0;
    }

    // Displays device details including the assigned patient ID
    public void DisplayDeviceDetails()
    {
        Console.WriteLine($"Device ID: {DeviceID}");
        Console.WriteLine($"Device Name: {DeviceName}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Assigned Patient ID: {(IsAssigned() ? AssignedPatientID.ToString() : "Not Assigned")}");
    }
}


public class HealthReading
{
    public int ReadingID { get; set; }
    public int DeviceID { get; set; }
    public string ReadingType { get; set; }
    public float ReadingValue { get; set; }
    public DateTime Timestamp { get; set; }

    // Checks if the reading value falls within acceptable clinical ranges
    public bool IsValidReading()
    {
        switch (ReadingType.ToLower())
        {
            case "heartrate":
                return ReadingValue >= 40 && ReadingValue <= 180;
            case "bloodpressure":
                return ReadingValue >= 60 && ReadingValue <= 180;
            case "temperature":
                return ReadingValue >= 35.0f && ReadingValue <= 42.0f;
            default:
                return false;
        }
    }

    // Displays the details of the health reading
    public void DisplayReadingDetails()
    {
        Console.WriteLine($"Reading ID: {ReadingID}");
        Console.WriteLine($"Device ID: {DeviceID}");
        Console.WriteLine($"Type: {ReadingType}");
        Console.WriteLine($"Value: {ReadingValue}");
        Console.WriteLine($"Timestamp: {Timestamp}");
        Console.WriteLine($"Valid Reading: {IsValidReading()}");
    }
}