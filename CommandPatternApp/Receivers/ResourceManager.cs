namespace CommandPatternApp.Receivers
{
    public class ResourceManager
    {
        public void AccessResource()
        {
            Console.WriteLine("ResourceManager: Resource accessed.");
        }

        public void UndoAccessResource()
        {
            Console.WriteLine("ResourceManager: Access to resource has been undone.");
        }

        public void ModifyResource()
        {
            Console.WriteLine("ResourceManager: Resource modified.");
        }

        public void UndoModifyResource()
        {
            Console.WriteLine("ResourceManager: Modification to resource has been undone.");
        }
    }
}