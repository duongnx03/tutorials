#include "stdio.h"

int main(){
  int year, money;

  printf("Input year: ");
  scanf("%d", &year);

  printf("Input money: ");
  scanf("%d", &money);

  if (year >= 10) {
    if (money >= 5000) {
      printf("VVIP\n");
    }
  }if (year >= 5) {
    if (money >= 3000) {
      if (money < 5000) {
        printf("VIP\n");
      }
    }
  }if (year >= 0) {
    if (money < 3000) {
      printf("member\n");
    }
  }if (year >= 0) {
    if (money > 3000) {
      printf("client\n");
    }
  }
}


/*
+ year = 10 && money = 5000 => VVIP
+ year = 5  && money = 4000 => VIP
+ year = 0  && money = 3000 => member
+ year = 5  && money = 5000 => client
+ year = 0  && money = 1000 => member
+ year = 3  && money = 4000 => client
+ year = 6  && money = 6000 => client 

*/


/*
Write more succinctly:
  if (year >= 10 && money >= 5000) {
    printf("member VVIP");
  } else if(year >= 5 && (money > 3000 && money < 5000)){
    printf("VIP");
  } else if(year >= 0 && money < 3000){
    printf("member");
  } esle{
    printf("client\n");
  }
*/


/*
true && true   => true
false && false => false
true && false  => false
false && true  => false

true || true   => true
false || true  => true
false || false => false
true  || false => true
*/
