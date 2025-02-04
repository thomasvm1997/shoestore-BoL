import { useState } from 'react'
import SearchBarComponent from './components/SearchBarComponent'
import ShoeListCardComponent from './components/ShoeListCardComponent'
import useFetchShoeFilters from './hooks/useFetchShoeFilters'
import useFetchShoesById from './hooks/useFetchShoeById'
import ShoeDetailsCardComponent from './components/ShoeDetailsCardComponent'
import './App.css'

function App() {
  const [searchTerm, setSearchTerm] = useState("");
  const [getId, setGetId] = useState<number>(1)
  const {shoeFiltered} = useFetchShoeFilters(undefined, undefined, undefined, undefined, undefined, searchTerm);
  const shoeById = useFetchShoesById(getId);

  return (

    <>
      <div className="container">
        <div className="row-1">
          <h2>BoL Shoes</h2>
          <SearchBarComponent onSearch={setSearchTerm}></SearchBarComponent>
        </div>
        <div className="row-2">
            <div className="column">Column 1</div>
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
