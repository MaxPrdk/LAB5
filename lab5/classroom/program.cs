namespace classroom
{
    internal class program
    {
        static void Main(string[] args)
        {
            classroom classroom = new classroom(new excelentpupil(), new badpupil(), new goodpupil());
            classroom.showpupils();
        }
    }
}