using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer
{
    public class AnimationService : IAnimationService
    {
        private IlluminationParameters parameters;
        private int interval;
        public AnimationService(int interval, IlluminationParameters parameters)
        {
            this.parameters = parameters;
            this.interval = interval;
        }
        public void AnimateFrame()
        {

        }
    }
}
