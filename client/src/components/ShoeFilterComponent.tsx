
import useFetchShoeBrands from "../hooks/useFetchShoeBrands";
import useFetchShoeCategories from "../hooks/useFetchShoeCategories";

const ShoeFilterComponent = ({onGetCategoryId, onGetBrandId, onGetMinPrice, onGetMaxPrice, onGetSize} : 
                             {
                                onGetCategoryId: (getCategoryId: number) => void,
                                onGetBrandId: (getBrandId: number) => void,
                                onGetMinPrice: (getMinPrice: number) => void,
                                onGetMaxPrice: (getMaxPrice: number) => void,
                                onGetSize: (getSize: number) => void,
                             }) =>{
                  const {shoeBrands} = useFetchShoeBrands();
                  const {shoeCategories} = useFetchShoeCategories();

             return(
                    <div className="filterContainer">
                        <div className="categoryFilter">
                        {
                            shoeCategories.map((category) => (
                                
                                <label key={category.id} className="radioLabel">

                                    {category.name}
                                    
                                <input 
                                    type="radio" 
                                    name="category" 
                                    value={category.name}
                                    onChange={() => onGetCategoryId(category.id)}
                                />
                                </label>
                                
                            ))
                        }
                        </div>
                        <div className="brandFilter">
                            
                        {
                            shoeBrands.map((brand) => (
                                <label key={brand.id} className="radioLabel">
                                    {brand.name}
                                <input 
                                    type="radio" 
                                    name="brand" 
                                    value={brand.name}
                                    onChange={() => onGetBrandId(brand.id)}
                                />
                            </label>
                            ))
                            
                        }
                        </div>
                        <div className="priceFilter">
                        <h3>Price Range</h3>
                <div className="sliderContainer">
                        <input 
                                type="range" 
                                min="0" 
                                max="500" 
                                step="5"
                                defaultValue="0"
                                onChange={(e) => onGetMinPrice(Number(e.target.value))}
                                className="slider"
                            />
                            <input 
                                type="range" 
                                min="0" 
                                max="500" 
                                step="5"
                                defaultValue="500"
                                onChange={(e) => onGetMaxPrice(Number(e.target.value))}
                                className="slider"
                            />
                        </div>
                        <div className="priceDisplay">
                            <span>Min: $0</span>
                            <span>Max: $500</span>
                        </div>
                        </div>
                        <div className="sizeFilter">
                        <h3>Size</h3>
                        <select className="sizeSelect" onChange={(e) => onGetSize(Number(e.target.value))}>
                            <option value="">Select Size</option>
                            {[36, 37, 38, 39, 40, 41, 42, 43, 44, 45].map((size) => (
                                <option key={size} value={size}>{size}</option>
                            ))}
                        </select>
                        </div>
                    </div>

             );                
                            
    
};

export default ShoeFilterComponent  