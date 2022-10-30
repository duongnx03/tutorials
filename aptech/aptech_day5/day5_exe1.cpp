#include <stdio.h>

int main(){
  int num, count = 0;

  printf("Input num: \n");
  scanf("%d", &num);

  while (num > 0)
  {
    num = num / 10;
    count++;
  }
  printf("Tong cac chu so la: %d\n", count);
}
