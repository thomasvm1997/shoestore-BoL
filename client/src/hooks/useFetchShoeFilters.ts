import { useState, useEffect } from "react";
import { Shoe } from "../types/Shoe";

const useFetchShoeFilters = (categoryId?: number, brandId?: number, 
                            minPrice?: number, maxPrice?: number, size?: number, name?: string) => {
    const [shoeFiltered, SetShoeFiltered] = useState<Shoe[]>([]);


    const params = new URLSearchParams();

    if (categoryId) params.append("categoryId", categoryId.toString());
    if (brandId) params.append("brandId", brandId.toString());
    if (minPrice) params.append("minPrice", minPrice.toString());
    if (maxPrice) params.append("maxPrice", maxPrice.toString());
    if (size) params.append("size", size.toString());
    if (name) params.append("name", name);

    const url = `https://localhost:7278/api/Shoes/filter?${params.toString()}`;
                              
    useEffect(() => {
        fetch(url)
        .then((response) =>{
            if(!response.ok){
                throw new Error(`HTTP error! Status: ${response.status}`);
            }
            return response.json();
        })
        .then((data) => {
            SetShoeFiltered(data);

        })
        .catch((error) => {
            console.error("Error filtering shoes", error);

        })
    }, [categoryId, brandId, minPrice, maxPrice, size, name]);
    return {shoeFiltered}
};
export default useFetchShoeFilters;