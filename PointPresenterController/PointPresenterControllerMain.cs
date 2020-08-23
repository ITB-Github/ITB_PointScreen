using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PointInteractor;

namespace PointPresenterController
{
    public class PointPresenterControllerMain
    {
        private Controller ctrl;
        private Presenter presenter;
        public PointPresenterControllerMain(PointViewModel pvm, TeamChosenViewModel tvm, PreviewViewModel prvm)
        {
            presenter = new Presenter(tvm, pvm, prvm);
            ctrl = new Controller();
            //
            tvm.AttachController(ctrl);
            pvm.AttachController(ctrl);
            prvm.AttachController(ctrl);
        }

        public OutputBoundary GetOutputBoundary()
        {
            return presenter as OutputBoundary;
        }

        public void AttachInputBoundary(InputBoundary input)
        {
            ctrl.AttachInput(input);
        }

    }
}
