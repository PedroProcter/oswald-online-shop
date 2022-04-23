
using Microsoft.EntityFrameworkCore;
using oswald_online_shop.Models;

namespace oswald_online_shop.Data.AdminServices.SliderAdminServices
{
    public class SliderAdminService
    {
        public readonly MyDBContext _dbContext;

        public SliderAdminService(MyDBContext myDBContext)
        {
            _dbContext = myDBContext;
        }

        public async Task<SliderOswald> getOnlySliderImage(int id)
        {
            return await _dbContext.Slider.FindAsync(id);
        }
        public async  Task<IEnumerable<SliderOswald>> getAllSliderImage()
        {
            return await _dbContext.Slider.ToListAsync();
        }


        public async Task<bool> saveSliderImage(SliderOswald slider)
        {
            if (slider.id == 0)
                return await insertSliderImage(slider);
            else
                return await updateSlider(slider);
        }

        public async Task<bool> insertSliderImage(SliderOswald slider)
        {
            _dbContext.Slider.Add(slider);
            return await _dbContext.SaveChangesAsync()>0;
        } 

        public async Task<bool> deleteSliderImage(int id)
        {
            var slider = await _dbContext.Slider.FindAsync(id);
            _dbContext.Slider.Remove(slider);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> updateSlider(SliderOswald slider)
        {
            _dbContext.Entry(slider).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync() > 0;
        }

    }
}
