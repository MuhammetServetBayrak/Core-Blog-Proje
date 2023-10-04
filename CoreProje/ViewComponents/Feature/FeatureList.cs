using BusinessLayer.Concretee;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProje.ViewComponents.Feature
{
    public class FeatureList:ViewComponent  //Her bir classı parçala yönet şeklinde tasarlayıp kod karmaşıklığından kurtulmak için ViewComponent mimarisini kullanıyoruz.
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()  //Burada tanımlanan metotların isimleri her zaman Invoke şeklindedir.
        {
            var values = featureManager.TGetList();
            return View(values); //Burada addView seçeneği olmadığı için bizde oluşturduğumuz bu classın adıyla /Views/Shared/Components yolunda bir klasör oluşturacağız
                           //Oluşturulan klasörün içine ise Default adı altında PartialView ekleyeceğiz IDE kendisi bu yolu otomatik bulup view'e yönlendiriyor.
        }
    }
}
