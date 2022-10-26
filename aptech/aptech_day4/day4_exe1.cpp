#include <stdio.h>

int main(){
  //
  // int num, count = 1, temp = 0;
  //
  // printf("Input num: \n");
  // scanf("%d", &num);
  //
  // while (count <= num)
  // {
  //   temp = num - count;
  //   count++;
  //   printf("%d\n", temp);
  // }

  int num;

   printf("Input num: \n");
   scanf("%d", &num);

   while (num > 0)
   {
     printf("%d\n", num);
     num--;
   }
}
