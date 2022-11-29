
namespace Assembly1 
{
    internal class OtherClassInSameAssembly // Outside the Class | Different Namespace | Same Asembly
    {
        SampleClass sampleClass = new SampleClass();

        void FeildsCheck()
        {
            //sampleClass.fieldPrivate = 1; // Error
            //sampleClass.fieldPrivateProtected = 1; // Error
            sampleClass.fieldInternal = 1; // work
            //sampleClass.fieldProtected = 1; // Error
            sampleClass.fieldProtectedInternal = 1; // work
            sampleClass.fieldPublic = 1; // work
        }
    }
}
