namespace GraspExamples.ProtectedVariations.Right
{
    public class QualitySongControllerOk
    {
        public void ConvertQuality(ISong song)
        {
            song.Convert(128);
        }
    }
}
