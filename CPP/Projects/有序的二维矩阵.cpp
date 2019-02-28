bool searchMatrix(vector<vector<int>>& matrix, int target) {
    // ÐÐ
    int m = matrix.size();
    if (m <= 0)
        return false;
    // ÁÐ
    int n = matrix[0].size();
    if (n <= 0)
        return false;
    
    int i = m - 1;
    int j = 0;
    while (i >= 0 && j < n) {
        if (target == matrix[i][j]) {
            return true;
        }
        else if (target < matrix[i][j]) {
            i--;
        }
        else {
            j++;
        }
    }
    return false;
}