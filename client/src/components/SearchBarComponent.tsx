import { useState } from "react";

const SearchBarComponent = ({ onSearch }: { onSearch: (searchTerm: string) => void }) => {
    const [searchTerm, setSearchTerm] = useState("");

    return (
        
        <div>
            <input
                type="text"
                placeholder= "look for shoes..."
                value={searchTerm}
                onChange={(e) => setSearchTerm(e.target.value)}
            />
            <button onClick={() => onSearch(searchTerm)}>Search</button>
        </div>
    );
};

export default SearchBarComponent