import { useState, useEffect } from "react";
import { ShoeCategory } from "../types/ShoeCategory";

const useFetchShoeCategories = () => {
    const [ShoeCategory, SetShoeCategories] = useState<ShoeCategory[]>([])

    useEffect(() => {
        fetch("https://localhost:7278/api/Categories")
        .then((response) => response.json())
        .then((data) => SetShoeCategories(data))
        .catch((error) => console.error("error fetching shoes", error));
    }, []);

    return ShoeCategory;
}

export default useFetchShoeCategories;