namespace Practice_4
{
    class SecondProgram
    {
        // Must be public to call in another class
        public int count = 9;
        
        // Instead of making the variable public it is good practice to 
        // use methods to get and set the data.


        // This variable is not accessible outside this class 
        // (with or without 'private' keyword)
        private string name = "No name is set";

        // Must be public to access
        public string GetName()
        {
            return name;
        }

        // Must be public to access
        public void SetName(string name)
        {
            // 'this' keyword is used to refer the current object.
            this.name = name;
        }
    }
}