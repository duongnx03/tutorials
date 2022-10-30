#include <stdio.h>

int main(){
  int num, count = 0, donvi , chuc, tram, nghin;

  printf("Input num: \n");
  scanf("%d", &num);

  while (num > 0)
  {
    if (count == 0) {
      donvi = num % 10;
    }else if(count == 1){
      chuc = num % 10;
    }else if (count == 2) {
      tram = num % 10;    
    }else if (count == 3) {
      nghin = num % 10;
    }
    num /= 10;
    count++;
  }
  printf("Tong cac chu so la: %d\n", count);
  
  if (count == 4) {
    printf("So hang nghin la: %d\n", nghin);
  }if (count >= 3) {
    printf("So hang tram la: %d\n", tram);
  }if (count >= 2) {
    printf("So hang chuc la: %d\n", chuc);
  }if (count >= 1) {
    printf("So hang don vi la: %d\n", donvi);
  }
}
