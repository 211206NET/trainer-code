import { Review } from './review'

export type Restaurant = {
    id: number;
    name: string;
    streetAddress: string;
    city: string;
    state: string;
    reviews: Review[];
}