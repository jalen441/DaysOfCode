// Day 1
function swapEnds(nums) {
    let holder = nums[0];

    nums[0] = nums[nums.length - 1];

    nums[nums.length -1] = holder;

    return nums;
};

// Day 2
function has12(nums) {
    return (nums.indexOf(1) < nums.indexOf(2) && nums.indexOf(2) != -1);
};

// Day 3
function greenTicket(a, b, c) {
    let result = 0;

    if(a === b && b === c && a === c) {
        result = 20;
    } else if(a === b || b === c || a === c) {
        result = 10;
    }

    return result;
};

// Day 4
function start1(a, b) {
    let count = 0;

    if(a.length > 0 && a[0] === 1) {
        count++;
    }

    if(b.length > 0 && b[0] === 1) {
        count++;
    }

    return count;
};

// Day 5
function fizzArray3(start, end) {
    let output = [];
    
    if(end > start) {
        for(let i = start; i < end; i++) {
            output.push(i);
        }
    }

    return output;
}

// Day 6
function only14(nums) {
    let result = true;

    for(let i = 0; i < nums.length; i++) {
        if(nums[i] != 1 && nums[i] != 4) {
            result = false;
            break;
        }
    }

    return result;
}