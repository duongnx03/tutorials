#include <stdio.h>

int main(){
  int num, cnt = 0;
  
  printf("Input num: \n");
  scanf("%d", &num);

  while(cnt < 10){
    printf("%d * %d = %d \n", num, cnt +1, num*(cnt +1));
    cnt = cnt + 1;
  }
}
