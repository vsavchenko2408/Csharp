class MyClass
{
    private int x;
    public MyClass(int x)
    {
    this.x = x;
    }
    public void set_x(int x)
    {
        this.x = x;
    }
    public int get_x()
    {
        return this.x;
    }


class Program
{
     static void Main()
    {
            MyClass a;
            a.set_x(15);


        

    }
}
