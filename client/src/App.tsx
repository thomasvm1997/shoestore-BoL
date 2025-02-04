import { useState } from 'react'
import SearchBarComponent from './components/SearchBarComponent'
import ShoeListCardComponent from './components/ShoeListCardComponent'
import useFetchShoeFilters from './hooks/useFetchShoeFilters'
import useFetchShoesById from './hooks/useFetchShoeById'
import ShoeDetailsCardComponent from './components/ShoeDetailsCardComponent'
import ShoeFilterComponent from './components/ShoeFilterComponent'
import './App.css'

function App() {
  const [searchTerm, setSearchTerm] = useState("");
  const [getId, setGetId] = useState<number>(0);
  const [getCategoryId, setGetCategoryId] = useState<number>();
  const [getBrandId, setBrandId] = useState<number>();
  const [getMinPrice, setMinPrice] = useState<number>();
  const [getMaxPrice, setMaxPrice] = useState<number>();
  const [getSize, setGetSize] = useState<number>();
  const {shoeFiltered} = useFetchShoeFilters(getCategoryId, getBrandId, getMinPrice, getMaxPrice, getSize, searchTerm);
  const shoeById = useFetchShoesById(getId);

  return (

    <>
      <div className="container">
        <div className="row-1">
          <h2>BoL Shoes</h2>
          <SearchBarComponent onSearch={setSearchTerm}></SearchBarComponent>
        </div>
        <div className="row-2">
            <div className="column">
              <ShoeFilterComponent onGetCategoryId={setGetCategoryId} 
                                   onGetBrandId={setBrandId}
                                   onGetMinPrice={setMinPrice}
                                   onGetMaxPrice={setMaxPrice}
                                   onGetSize={setGetSize}
              >

              </ShoeFilterComponent>
            </div>
            <div className="column">
              <ShoeListCardComponent onGetId={setGetId} shoes={shoeFiltered}></ShoeListCardComponent>
            </div>
            <div className="column">
              <ShoeDetailsCardComponent shoe={shoeById}></ShoeDetailsCardComponent>
            </div>
        </div>
    </div>
    </>
  )
}

export default App
