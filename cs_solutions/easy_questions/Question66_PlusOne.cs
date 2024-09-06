public int[] PlusOne(int[] digits) {
         int[]arr;
         double sum = 0;
        if(digits[digits.Length-1] == 9){
            sum = 0;
            double k =Math.Pow(10,digits.Length-1) ;
            for(int i=0;i<digits.Length;i++){
                sum += digits[i]*k;
                k/=10;
            }// העברת המערך למספר
            sum++;
            
               arr =  new int[digits.Length+1];   
        }
        else{
            sum = 0;
            double k =Math.Pow(10,digits.Length-1) ;
            for(int i=0;i<digits.Length;i++){
                sum += digits[i]*k;
                k/=10;
            }// העברת המערך למספר
            sum++;
            bool flag = false;

            arr =  new int[digits.Length] ;       
        }
        for(int i=0; i <arr.Length;i++){
            arr[i] = (int)sum%10;
            sum/=10;
        }// הכנסת הסכום למערך
        int[] newArr = new int[arr.Length];     
        int place=0; 
            for(int j =arr.Length-1; j>=0;j--){
                newArr[place] = arr[j];
                place++;
            }// יצירת מערך בצורה מסודרת
        return newArr;
    }