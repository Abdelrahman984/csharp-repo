namespace ConsoleApp1;

public class Student
{
    // The constructor
    public Student()
    {
        
    }

    
    
    /*
     Auto-implemented property
     * set: Allows modifying the value of the property.
       This property can be read and written to at any time.
     */
    public string Adress { get; set; }


    
    /*
     * init: Allows setting the value of the property,
       but only during object initialization
        (e.g., in the constructor or an object initializer).
       After the object is initialized, the property becomes read-only.
     */
    public int Adge { get; init; }
    
    // Implemented property
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }
    
}
