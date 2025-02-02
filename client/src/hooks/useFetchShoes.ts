import { useState, useEffect } from "react";
import { Shoe } from "../types/Shoe";

const useFetchShoes = () => {
    const [shoes, setShoes] = useState<Shoe[]>([])

    useEffect(() => {
        fetch("https://localhost:7278/api/Shoes")
        .then((response) => response.json())
        .then((data) => setShoes(data))
        .catch((error) => console.error("error fetching shoes", error));
    }, []);

    return shoes;
}

export default useFetchShoes;

