import { BaseType } from "./BaseType"
export type Shoe = BaseType & {
    decription: string;
    price: number;
    size: number;
    imageUrl: string;
    shoeBrandId: number;
    shoeBrandName: string;
    shoeCategoryId: number;
    shoeCategoryName: string;
}