#include <stdio.h>

int  main(){
  int num, count, i, j;

  printf("Input num: \n");
  scanf("%d", &num);

  for(i = 2; i <= num; i++) {
    count = 0;
    for (j = 0; j < i; j++) {
      if (i % j == 0) {
        count = 1;     
        break;
      }
    }
    if (count != 0) {
      printf("%d\n", i);
    }
  }
}
