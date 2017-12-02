using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPWorksheets {

    public class Worksheet2 {

        /// <summary>
        /// Returns 1
        ///    if the integer array is sorted in ascending or decending order,
        ///    if the array contains only a single element,
        ///    if the array is empty.
        /// Returns 0 otherwise.
        /// </summary>
        /// <param name="nums">integer array to be checked</param>
        /// <returns></returns>
        public static int IsSorted(int[] nums) {
            // if the list is not empty
            if (nums.Length != 0) {
                // if the list has more than one element
                if (nums.Length != 1) {
                    bool notAscending = false;

                    for (int i = 0; i < nums.Length; i++) {
                        if (i != 0) { // skip first iteration 
                            if (nums[i] < nums[i - 1]) // a number is less than its previous number
                                notAscending = true;
                        }
                    }

                    if (notAscending) {
                        for (int i = 0; i < nums.Length; i++) {
                            if (i != 0) { // skip first iteration 
                                if (nums[i] > nums[i - 1]) // a number is greater than its previous number
                                    return 0; // not ascending and descending
                            }
                        }
                    }
                }

            }


            return 1;
        }
        public static int IsSorted2(int[] nums) {
            // if the list is not empty
            if (nums.Length != 0) {
                // if the list has more than one element
                if (nums.Length != 1) {
                    int inc = 0;
                    int dex = 0;

                    for (int i = 0; i < (nums.Length - 1); i++) {
                        if (nums[i] < nums[i + 1]) {
                            inc++;
                        } else {
                            dex++;
                        }
                    }

                    if (inc == (nums.Length - 1) || dex == (nums.Length - 1))
                        return 1;
                    else
                        return 0;
                }

            }

            return 1;
        }
    }

}
