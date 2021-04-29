using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem1 : MonoBehaviour
{
    /// <summary>
    /// 
    /// 이동하는 오브젝트의 수, 딜레이와 이동시간의 비율, 총 이동시간을 가지고 오브젝트 하나의 이동시간과 딜레이를 구하는 코드 작성
    ///  - 이차방정식을 이용
    ///  
    /// Github안의 프로젝트에서 Example.md 파일 참고
    /// https://github.com/WoorilineClientTeam/Interview2021/blob/master/Assets/Example.md
    /// 
    /// </summary>
    /// <param name="objCount">이동할 물체의 수</param>
    /// <param name="moveRatio">(딜레이 + 이동시간)에서 이동시간이 차지하는 비율</param>
    /// <param name="totalTime">총 이동 시간</param>
    /// <returns></returns>

    [TestMethod]
    public void Solution(int objCount = 5, float moveRatio = 0.8f, float totalTime = 1f)
    {
        float moveTime = 0f;
        float delayTime = 0f;


    }
}
