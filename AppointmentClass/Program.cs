using System;

public class Appointment {
    private bool[,] schedule = new bool[8, 60]; // 8 periods, 60 minutes each

    // Helper method: Check if a minute is free
    private bool IsMinuteFree(int period, int minute) {
        return !schedule[period - 1, minute];
    }

    // Helper method: Reserve a block of minutes
    private void ReserveBlock(int period, int startMinute, int duration) {
        for (int i = 0; i < duration; i++) {
            schedule[period - 1, startMinute + i] = true;
        }
    }
    

    //partb Senanur Bilgin 
    //find and reserve the earliest avalible block within range of periods

    public bool MakeAppointment(int startPeriod, int endPeriod, int duration) 
    {
        for (int period = startPeriod; period <= endPeriod; period++)
        {
            int startMinute = FindFreeBlock(period, duration);
            if (startMinute != -1)
            {
                ReserveBlock(period, startMinute, duration);
                return true;
            }
        }
        return false;
    }
}