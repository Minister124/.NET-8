for(int i = 1; i <= 100; i++){
    int a = i % 3;
    int b = i % 5;
    if(a == 0 && b == 0){
        Write("FizzBuzz,");
    }
    else if(a == 0){
        Write("Buzz,");
    }else if (b == 0){
        Write("Fizz,");
    }
    else{
        Write($"{i},");
    }
}