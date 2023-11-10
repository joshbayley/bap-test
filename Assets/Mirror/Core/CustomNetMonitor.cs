// This class will monitor network packets and record their size
namespace Mirror
{
    public static class CustomNetMonitor
    {
        public static int latestFrame;
        public static int totalBytes;
        public static int totalBatches;

        // Since we use netReader.Remaining, only Record Data for the first frame.
        public static void RecordData(int frame, int numBytes, int batches)
        {
            // UnityEngine.Debug.Log($"RECV - {numBytes} bytes | {UnityEngine.Time.frameCount}");

            // Only record first frame's "remaining
            if (latestFrame == frame)
                return;
        
            latestFrame = frame;
            totalBytes = numBytes;
            totalBatches = batches;
        }
    }
}