using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_singleton
{
    public class Singleton
    {
        // Lazy<T>를 사용하여 Singleton 인스턴스를 선언합니다.
        private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>(() => new Singleton());
        int v;

        // Singleton 인스턴스를 가져오는 속성입니다.
        public static Singleton Instance => lazyInstance.Value;

        
        private Singleton()
        {
            this.v = 0;
        }

        // 다른 메서드나 속성을 추가할 수 있습니다.
        public void add(int num)
        {
            this.v += num;
        }

        public int GetV()
        {
            return this.v;
        }
    }
}
