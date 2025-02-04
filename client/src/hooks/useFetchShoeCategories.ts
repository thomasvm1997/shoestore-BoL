import { useState, useEffect } from "react";
import { ShoeCategory } from "../types/ShoeCategory";

const useFetchShoeCategories = () => {
    const [shoeCategories, SetShoeCategories] = useState<ShoeCategory[]>([]);

    useEffect(() => {
        fetch("https://localhost:7278/api/Categories")
        .then((response) => {
            return response.json();
        })
        .then((data) => {
            SetShoeCategories(data);
        })
        .catch((error) => {
            console.error("Error fetching categories:", error);
        });
}, []);

return { shoeCategories};
}

export default useFetchShoeCategories;