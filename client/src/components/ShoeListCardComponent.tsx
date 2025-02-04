import { Shoe } from "../types/Shoe";

const ShoeListCardComponent = ({ onGetId, shoes }: { onGetId: (getId: number) => void, shoes: Shoe[] | string[] }) => {
    const isInvalidShoe = Array.isArray(shoes) && shoes.length === 1 && shoes[0] === "No shoes match the filter criteria";
    return (
        <div>
            <h1 className="titleList">Out now!</h1>
        <div className="cardsContainer" onClick={() => onGetId(0)}>
            {!isInvalidShoe ? 
            (
                (shoes as Shoe[]).map((shoe) => (
                    <div className="shoeCard" key={shoe.id}
                    onClick={(e) => 
                        {
                            e.stopPropagation();
                            onGetId(shoe.id);
                        }
                    }
                    style={{ cursor: "pointer" }}> 
                        <h3>{shoe.name}</h3>
                        <img src={shoe.imageUrl} alt={shoe.name} className="shoeImage" />
                        <p>{shoe.shoeBrandName}</p>
                        <span>{shoe.price.toFixed(2)}</span>
                    </div>
                ))
                
            ) 
            : 
            (
                <div className="noShoes">No shoes found.</div>
            )}
        </div>
        </div>
    );
  };
  
  export default ShoeListCardComponent;