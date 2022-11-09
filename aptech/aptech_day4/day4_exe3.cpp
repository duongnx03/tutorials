#include <stdio.h>

void main(){
  int month;

  printf("Input num: \n");
  scanf("%d", &month);

  switch (month) {
    case 1: case 2: case 3:
      printf("quy 1\n");
      break;
    case 4: case 5: case 6:
      printf("quy 2\n");
      break;
    case 7: case 8: case 9:
      printf("quy3\n");
      break;
    case 10: case 11: case 12:
      printf("quy 4\n");
      break;
    default :
      printf("error\n");
  }

  switch (month) {
    case 17:
    case 18:
    case 19:
    case 20:
      printf("Lay");
      break;

    default:
      printf("Ko lay");
      break;
  }
}
