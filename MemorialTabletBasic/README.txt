



Reference code for future in need

Imports System.Printing

Dim server As LocalPrintServer = New LocalPrintServer();
PrintQueueCollection queueCollection = server.GetPrintQueues();
PrintQueue printQueue = null;

foreach(PrintQueue pq In queueCollection)
{
    If (pq.FullName == PrinterName) Then
        printQueue = pq;
}

Int numberOfJobs = 0;
If (printQueue!= null) Then
    numberOfJobs = printQueue.NumberOfJobs;
