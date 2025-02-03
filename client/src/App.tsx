import { useState } from 'react'
import ShoeStore from './components/ShoeStore'
import SearchBarComponent from './components/SearchBarComponent'
import './App.css'

function App() {
  const [searchTerm, setSearchTerm] = useState("");

  return (

    <>
      <div className="container">
        <div className="row-1">
          <h2>BoL Shoes</h2>
          <SearchBarComponent onSearch={setSearchTerm}></SearchBarComponent>
        </div>
        <div className="row-2">
            <div className="column">Column 1</div>
            <div className="column">Column 2 (Twice as wide)</div>
            <div className="column">Column 3</div>
        </div>
    </div>
    </>
  )
}

export default App
