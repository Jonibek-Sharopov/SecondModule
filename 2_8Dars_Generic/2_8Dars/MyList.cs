namespace _2_8Dars;

public class MyList
{
    private int[] array;
    private int size;

    public MyList()
    {
        array = new int[10];
        size = 0;
    }

    private void Resize()
    {
        int[] newArray = new int[array.Length * 2];

        for (var i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }

        array = newArray;
    }

    public void AddElement(int element)
    {
        if (size == array.Length)
        {
            Resize();
        }

        array[size++] = element;
    }
}