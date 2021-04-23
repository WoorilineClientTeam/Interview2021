using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem2 : MonoBehaviour
{
    /// <summary>
    /// 숫자 롤링 구현
    /// 
    /// - 특정 자릿수를 넘어가면 단위변경되어야 함( K : 1,000 / M : 1,000,000 / B : 1,000,000,000 / T : 1,000,000,000,000
    /// 예) 5000 => 5K, 5555 => 5.555K, 60767 => 60.767K
    /// 
    /// - 시작할때 숫자 폼이 롤링중에도 유지되어야 함
    /// 예) 5K -> 8K일때는 소수점 밑을 표시하지 않음. 5.55k -> 7.89K일때는 소수점 아래 두자릿수까지 롤링되도록 구현(롤링중에 6K, 7K가 되는 상황에서도 6.00K, 7.00K 이런식으로 롤링되도록)
    /// 
    /// </summary>

    public void Solution(long startNum, long endNum)
    {

    }
}
