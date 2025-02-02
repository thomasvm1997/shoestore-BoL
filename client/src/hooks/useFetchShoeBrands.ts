import { useState, useEffect } from "react";
import { ShoeBrand } from "../types/ShoeBrand";

const useFetchShoeBrands = () => {
    const [shoeBrands, SetShoeBrands] = useState<ShoeBrand[]>([])

    useEffect(() => {
        fetch("https://localhost:7278/api/Brands")
        .then((response) => response.json())
        .then((data) => SetShoeBrands(data))
        .catch((error) => console.error("error fetching shoes", error));
    }, []);

    return shoeBrands;
}

export default useFetchShoeBrands;