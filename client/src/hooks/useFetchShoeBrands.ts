import { useState, useEffect } from "react";
import { ShoeBrand } from "../types/ShoeBrand";

const useFetchShoeBrands = () => {
    const [ShoeBrands, SetShoeBrands] = useState<ShoeBrand[]>([]);
    const [loading, setLoading] = useState<boolean>(true);
    const [error, setError] = useState<Error | null>(null);

    useEffect(() => {
        fetch("https://localhost:7278/api/Brands")
        .then((response) => {
            if (!response.ok) {
                throw new Error(`HTTP error! Status: ${response.status}`);
            }
            return response.json();
        })
        .then((data) => {
            SetShoeBrands(data);
            setLoading(false);
        })
        .catch((error) => {
            console.error("Error fetching categories:", error);
            setError(error);
            setLoading(false);
        });
}, []);

return { ShoeBrands, loading, error };
}

export default useFetchShoeBrands;