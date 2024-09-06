public int SearchInsert(int[] nums, int target) {   
        for(int i=0; i <nums.Length;i++){
            if(nums[i] == target){
                return i;
            }
        }
        for(int i=1; i <nums.Length;i++){
            if(nums[i-1] < target && nums[i]>target){
                return i;
            }
        }
        if(nums[nums.Length-1]< target )
            return nums.Length;
        if(nums[0]> target )
            return 0;
        
        return -1;
    }