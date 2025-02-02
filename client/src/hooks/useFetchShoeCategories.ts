import { useState, useEffect } from "react";
import { ShoeCategory } from "../types/ShoeCategory";

const useFetchShoeCategories = () => {
    const [shoeCategories, SetShoeCategories] = useState<ShoeCategory[]>([]);
    const [loading, setLoading] = useState<boolean>(true);
    const [error, setError] = useState<Error | null>(null);

    useEffect(() => {
        fetch("https://localhost:7278/api/Categories")
        .then((response) => {
            if (!response.ok) {
                throw new Error(`HTTP error! Status: ${response.status}`);
            }
            return response.json();
        })
        .then((data) => {
            SetShoeCategories(data);
            setLoading(false);
        })
        .catch((error) => {
            console.error("Error fetching categories:", error);
            setError(error);
            setLoading(false);
        });
}, []);

return { shoeCategories, loading, error };
}

export default useFetchShoeCategories;