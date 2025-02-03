import { useState } from 'react'
import SearchBarComponent from './components/SearchBarComponent'
import ShoeListCardComponent from './components/ShoeListCardComponent'
import useFetchShoeFilters from './hooks/useFetchShoeFilters'
import './App.css'

function App() {
  const [searchTerm, setSearchTerm] = useState("");
  const {shoeFiltered} = useFetchShoeFilters(undefined, undefined, undefined, undefined, undefined, searchTerm);

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
              <ShoeListCardComponent shoes={shoeFiltered}></ShoeListCardComponent>
            </div>
            <div className="column">Column 3</div>
        </div>
    </div>
    </>
  )
}

export default App
