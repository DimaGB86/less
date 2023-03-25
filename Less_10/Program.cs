int[] array = {1, 22, 33, 43, 54, 53, 64, 54, 32};

int n = array.Length;
int find = 54;

int index = 0;

while (index < n)
{

  if(array[index] == find)
  {
     Console.WriteLine(index);
     break;
  }
   //index = index + 1;
   index++;
}