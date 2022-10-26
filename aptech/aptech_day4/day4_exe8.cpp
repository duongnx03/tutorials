#include <stdio.h>

int main(){
  int num, cnt = 0;

  printf("Input num: \n");
  scanf("%d", &num);

  do
  {
    printf("Hello\n");
    cnt++;
  } while(cnt < num);

}
