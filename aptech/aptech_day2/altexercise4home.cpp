#include "stdio.h"

/*Cách này là em làm theo thực tế, theo chỉ tiêu chính là money,
  không quan tâm đến year 
  -Chỉ cần money >= 5000 => member VVIP
  -money >= 3000 && money > 5000 => VIP
  -money < 3000 => member

*/
int main(){
  int year, money;

  printf("Input year: ");
  scanf("%d", &year);

  printf("Input money: ");
  scanf("%d", &money);

   
  if(year >= 0){
    if (money >= 5000) {
      printf("member VVIP\n");
    }
  }if (year >= 0) {
    if(money >= 3000){
      if (money < 5000) {
        printf("VIP\n");
      }
    }
  }if(year >= 0) {
    if (money < 3000) {
      printf("member\n");
    }
  }
} 






