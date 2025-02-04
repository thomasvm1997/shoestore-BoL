import { useState, useEffect } from "react";
import { ShoeBrand } from "../types/ShoeBrand";

const useFetchShoeBrands = () => {
    const [shoeBrands, SetShoeBrands] = useState<ShoeBrand[]>([]);

    useEffect(() => {
        fetch("https://localhost:7278/api/Brands")
        .then((response) => {
            return response.json();
        })
        .then((data) => {
            SetShoeBrands(data);
        })
        .catch((error) => {
            console.error("Error fetching categories:", error);
        });
}, []);

return { shoeBrands};
}

export default useFetchShoeBrands;